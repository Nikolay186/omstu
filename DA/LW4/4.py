morze = {'а': '.-', 'б': '-...', 'в': '.--', 'г': '--.', 'д': '-..', 'е': '.', 'ё': '.', 'ж': '...-', 'з': '--..', 'и': '..', 'й':
            '.---', 'к': '-.-', 'л': '.-..', 'м': '--', 'н': '-.', 'о': '---', 'п': '.--.', 'р': '.-.', 'с': '...', 'т': '-', 'у': '..-', 'ф': '..-.', 
            'х': '....', 'ц': '-.-.', 'ч': '---.', 'ш': '----', 'щ': '--.-', 'ъ': '--.--', 'ы': '-.--', 'ь': '-..-', 'э': '..-..', 'ю': '..--', 'я': '.-.-', ' ': '-···-'}

def encode():
    inp = input("String: ").strip()
    first = True
    encoded = [morze.get(c) for c in inp]

    for c in encoded:
        if not first:
            print(" ", end='')
        print(*c, sep='', end='')
        first = False
    decode(encoded)

def decode(inp):
    decoded = [get_key(c) for c in inp]
    first = True
    
    for c in decoded:
        if first:
            print('\n')

        print(c, sep='', end='')
        first = False
    print('\n')

def get_key(value):
    for k, v in morze.items():
        if v == value:
            return k

if __name__ == "__main__":
    encode()