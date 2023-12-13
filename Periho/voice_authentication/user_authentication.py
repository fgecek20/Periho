import os
import pyaudio
import time
import numpy
import soundfile
import librosa
import librosa.feature
from scipy.spatial import distance
import pyodbc
import speech_recognition
import argparse


def initialise_authentication_attempt():
    audio_format = pyaudio.paInt32
    channels = 1
    sample_rate = 24000
    buffer = 2048
    audio_stream = pyaudio.PyAudio().open(format=audio_format, channels=channels,
                                          rate=sample_rate, input=True, frames_per_buffer=buffer)

    sample = []
    duration = 5

    # print('SPEAK NOW')

    beginning = time.time()
    while time.time() - beginning < duration:
        input_data = audio_stream.read(buffer)
        audio_wave_form = numpy.frombuffer(input_data, dtype=numpy.int32)
        sample.append(audio_wave_form)

    audio_data = numpy.ravel(sample)
    output_path = f'PATH\\Periho\\voice_authentication\\authentication_attempt.wav'
    soundfile.write(output_path, audio_data, sample_rate)

    audio_stream.stop_stream()
    audio_stream.close()

    return output_path


def extract_features(path):
    y, sr = librosa.load(path)
    mfccs = librosa.feature.mfcc(y=y, sr=sr, n_mfcc=13)
    fixed_size = 2964
    if mfccs.shape[1] < fixed_size:
        mfccs = numpy.pad(mfccs, ((0, 0), (0, fixed_size - mfccs.shape[1])), mode='constant')
    else:
        mfccs = mfccs[:, :fixed_size]
    return mfccs.flatten()


def cosine_similarity(sample1, sample2):
    return 1 - distance.cosine(sample1, sample2)


def verify_passphrase(username, path):
    connection_string = 'INSERT CONNECTION STRING'
    connection = pyodbc.connect(connection_string)

    query = 'select passphrase from profile where username=?'
    cursor = connection.execute(query, username)
    result = cursor.fetchone()
    cursor.close()
    connection.close()

    passphrase = str(result[0]) if result and result[0] is not None else None

    if passphrase == None:
        print('ERROR')
        return False
    else:
        recogniser = speech_recognition.Recognizer()

        with speech_recognition.AudioFile(path) as source:
            recogniser.adjust_for_ambient_noise(source)
            spoken_words = recogniser.record(source)

        try:
            uttered_phrase = recogniser.recognize_google(spoken_words)
            if uttered_phrase == passphrase:
                return True
            else:
                return False
        except speech_recognition.UnknownValueError:
            print('Unknown error occurred, failed to transcribe audio...')
        except speech_recognition.RequestError:
            print('Failed to request audio processing from Google Speech to Text service')


def authenticate(username):
    authentication_attempt_path = initialise_authentication_attempt()
    attempted_authentication = extract_features(authentication_attempt_path)

    threshold = 0.93

    connection_string = 'INSERT CONNECTION STRING'
    connection = pyodbc.connect(connection_string)

    query = 'select sample1_path from profile where username=?'
    cursor = connection.execute(query, username)
    result = cursor.fetchone()
    cursor.close()

    sample1_path = str(result[0]) if result and result[0] is not None else None

    if sample1_path == None:
        print('ERROR')
        connection.close()
        os.remove(authentication_attempt_path)
        return False
    else:
        sample1 = extract_features(sample1_path)
        similarity_score = cosine_similarity(sample1, attempted_authentication)
        if similarity_score >= threshold:
            authentication_successful = verify_passphrase(username, authentication_attempt_path)
            if authentication_successful:
                print('Authentication successful')
                connection.close()
                os.remove(authentication_attempt_path)
                return True
            else:
                print('Wrong passphrase')
                connection.close()
                os.remove(authentication_attempt_path)
                return False
        else:
            query = 'select sample2_path from profile where username=?'
            cursor = connection.execute(query, username)
            result = cursor.fetchone()
            cursor.close()

            sample2_path = str(result[0]) if result and result[0] is not None else None

            if sample2_path == None:
                print('ERROR')
                connection.close()
                os.remove(authentication_attempt_path)
                return False
            else:
                sample2 = extract_features(sample2_path)
                similarity_score = cosine_similarity(sample2, attempted_authentication)
                if similarity_score >= threshold:
                    authentication_successful = verify_passphrase(username, authentication_attempt_path)
                    if authentication_successful:
                        print('Authentication successful')
                        connection.close()
                        os.remove(authentication_attempt_path)
                        return True
                    else:
                        print('Wrong passphrase')
                        connection.close()
                        os.remove(authentication_attempt_path)
                        return False
                else:
                    query = 'select sample3_path from profile where username=?'
                    cursor = connection.execute(query, username)
                    result = cursor.fetchone()
                    cursor.close()

                    sample3_path = str(result[0]) if result and result[0] is not None else None

                    if sample3_path == None:
                        print('ERROR')
                        connection.close()
                        os.remove(authentication_attempt_path)
                        return False
                    else:
                        sample3 = extract_features(sample3_path)
                        similarity_score = cosine_similarity(sample3, attempted_authentication)
                        if similarity_score >= threshold:
                            authentication_successful = verify_passphrase(username, authentication_attempt_path)
                            if authentication_successful:
                                print('Authentication successful')
                                connection.close()
                                os.remove(authentication_attempt_path)
                                return True
                            else:
                                print('Wrong passphrase')
                                connection.close()
                                os.remove(authentication_attempt_path)
                                return False
                        else:
                            print("Authentication failed, voice doesn't match")
                            connection.close()
                            os.remove(authentication_attempt_path)
                            return False


def main():
    parser = argparse.ArgumentParser(description='Provide the username of the user you want to authenticate as an argument')
    parser.add_argument('username', type=str, help='The username of the user you want to authenticate')
    args = parser.parse_args()

    return authenticate(args.username)


if __name__ == '__main__':
    main()
