def check_interval():
    inp = int(input("Number: ").strip())
    print(inp > -5 and inp < 10)

def check():
    inp = int(input("Number: ").strip())
    print(inp % 4 == 0 and inp % 10 == 8)

if __name__ == "__main__":
    check_interval()
    check()