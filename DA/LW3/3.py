def numbers():
    inp = input("String: ").strip()
    t = 0
    numbers = [abs(float(x)) for x in inp.split(' ')]
    print(numbers)

def inner_list():
    source = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
    new = [x for sub in reversed(source) for x in reversed(sub)]
    print(new)


if __name__ == "__main__":
    numbers()
    inner_list()