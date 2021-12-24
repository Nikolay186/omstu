def get_indexes():
    inp = input("String: ").strip()
    indexes = [index for index in range(len(inp)) if inp.startswith("pa", index)]
    print(indexes)

def numbers():
    inp = input("String: ")
    t = 0
    numbers = [int(x) for x in inp.split(' ')]
    print(numbers)
    for num in numbers:
        t += num
    print("Sum =", t)

if __name__ == "__main__":
    get_indexes()
    numbers()