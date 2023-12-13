import os
import pyodbc
import pyaudio
import time
import numpy
import soundfile
import speech_recognition
import argparse


def enroll_new_user(username):
    list_of_paths = collect_samples(initialise_profile(username))
    sample1_path = list_of_paths[0]
    sample2_path = list_of_paths[1]
    sample3_path = list_of_paths[2]
    passphrase = setup_passphrase()

    connection_string = 'INSERT CONNECTION STRING'
    connection = pyodbc.connect(connection_string)

    query = 'select max(id) from profile'
    cursor = connection.execute(query)
    result = cursor.fetchone()
    cursor.close()

    userid = int(result[0]) + 1 if result and result[0] is not None else 1

    query = 'insert into profile(id, username, sample1_path, sample2_path, sample3_path, passphrase) values (?, ?, ?, ?, ?, ?)'
    connection.execute(query, userid, username, sample1_path, sample2_path, sample3_path, passphrase)
    connection.commit()
    connection.close()


def initialise_profile(username):
    path = f'PATH\\Periho\\voice_authentication\\profiles\\{username}\\samples'
    os.makedirs(path)
    return username


def collect_samples(username):
    audio_format = pyaudio.paInt32
    channels = 1
    sample_rate = 24000
    buffer = 2048
    audio_stream = pyaudio.PyAudio().open(format=audio_format, channels=channels,
                                          rate=sample_rate, input=True, frames_per_buffer=buffer)
    number_of_samples = 3
    sample_paths = []

    print('Prepare to record your samples...')
    countdown()

    for i in range(number_of_samples):
        print('Sample ', i + 1, ': SPEAK NOW')
        sample = []

        duration = 5
        beginning = time.time()

        while time.time() - beginning < duration:
            input_data = audio_stream.read(buffer)
            audio_wave_form = numpy.frombuffer(input_data, dtype=numpy.int32)
            sample.append(audio_wave_form)

        audio_data = numpy.ravel(sample)
        output_path = f'PATH\\Periho\\voice_authentication\\profiles\\{username}\\samples\\sample{i+1}.wav'
        soundfile.write(output_path, audio_data, sample_rate)
        sample_paths.append(output_path)
        print('Sample ', i + 1, ' Collected\n')
        time.sleep(1)

    audio_stream.stop_stream()
    audio_stream.close()

    return sample_paths


def setup_passphrase():
    print('Prepare to say your passphrase...')
    countdown()
    print('SPEAK NOW')

    recogniser = speech_recognition.Recognizer()
    with speech_recognition.Microphone() as source:
        recogniser.adjust_for_ambient_noise(source)
        spoken_phrase = recogniser.listen(source)

    try:
        chosen_passphrase = recogniser.recognize_google(spoken_phrase)
        return chosen_passphrase
    except speech_recognition.UnknownValueError:
        print('Something went wrong, please check your microphone')
    except speech_recognition.RequestError:
        print('Failed to request audio processing from Google Speech to Text service')


def countdown():
    seconds = 3
    while seconds >= 0:
        print(seconds)
        time.sleep(1)
        seconds -= 1


def main():
    parser = argparse.ArgumentParser(description='Provide the username of the user you wish to enroll as an argument')
    parser.add_argument('username', type=str, help='Username for the user whose profile you wish to create')
    args = parser.parse_args()

    enroll_new_user(args.username)


if __name__ == '__main__':
    main()
