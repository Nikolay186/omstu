def prepare(str):
    symbols = [',', ' ']
    for s in symbols:
        str = str.replace(s, "")
    analyze(str.lower())
    
def analyze(text):
    # get all letters entries
    letters_entries = []
    for i in range(len(text)):
        if text[i] == '.':
            break
        if text[i] not in letters_entries:
            letters_entries.append(text[i])
    print(*letters_entries)

    # get all letters with more than two entries
    repeating_letters = []
    for i in range(len(text)):
        if text[i] == '.':
            break
        letter = text[i]
        count = 0
        for j in range(len(text)):
            if text[j] == letter:
                count += 1
        if count > 2 and letter not in repeating_letters:
            repeating_letters.append(letter)
    print(*repeating_letters)

    # get unique letters
    unique_letters = []
    for i in range(len(text)):
        if text[i] == '.':
            break
        letter = text[i]
        count = 0
        for j in range(len(text)):
            if text[j] == letter:
                count += 1
        if count < 2 and letter not in unique_letters:
            unique_letters.append(letter)
    print(*unique_letters)

if __name__ == "__main__":
    prepare(input("Text: "))