import user_authentication
import argparse


def main():
    parser = argparse.ArgumentParser(description='Provide the username of the user you want to authenticate as an argument')
    parser.add_argument('username', type=str, help='The username of the user you want to authenticate')
    args = parser.parse_args()

    return user_authentication.authenticate(args.username)


if __name__ == '__main__':
    main()
