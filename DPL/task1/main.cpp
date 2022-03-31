#include<cstdlib>
#include<math.h>
#include<cstdio>
#include<iostream>
#include<iomanip>

const float a = 3.14159265;
const float f = 2.236067977;
const float g = 100.0;

float solve(int b, int c, int d);
float numerator(int b, int c, int d);
float denominator(int b, int c, int d);
void print(float b, float c, float d, float res);
bool is_in_interval(float num, float delta, float start);

int main(int argc, char *argv[]) {
    if (argc > 1) {
        if (argv[1] == std::string("--help")) {
            std::cout << "Args list: " << std::endl;
            std::cout << "B [3.0; 9.2], Δ = 0.61" << std::endl;
            std::cout << "C [0.0; 2.0], Δ = 0.15" << std::endl;
            std::cout << "D [4.2; 13.3], Δ = 0.1" << std::endl;
            std::cout << "----------------------" << std::endl << std::endl;
        }
    }

    float b = 0.0;
    float c = 0.0;
    float d = 0.0;
    do {
        std::cout << "B[3.0; 9.2], Δ = 0.61" << std::endl;
        std::cin >> b;
    } while (b < 3.0 || b > 9.2 || !is_in_interval(b, 0.61, 3.0));

    do {
        std::cout << "C[0.0; 2.0], Δ = 0.15" << std::endl;
        std::cin >> c;
    } while (c < 0.0 || c > 2.0 || !is_in_interval(c, 0.15, 0.0));

    do {
        std::cout << "D[4.2; 13.3], Δ = 0.1" << std::endl;
        std::cin >> d;
    } while (d < 4.2 || d > 13.3 || !is_in_interval(d, 0.1, 4.2));


    float result = solve(b, c, d);

    print(b, c, d, result);
}

float solve(int b, int c, int d) {
    float num = numerator(b, c, d);
    float denom = denominator(b, c, d);
    return num / denom;
}

float numerator(int b, int c, int d) {
    return (a * b) + (c * d) + (g * f);
}

float denominator(int b, int c, int d) {
    return pow(pow(a, 2.0) + pow(b, 1.0/3.0) + pow(c, 2.0), 1.0/2.0) * pow(pow(d, 2.0) + pow(g, 2.0) + pow(f, 2.0), 1.0/2.0);
}

void print(float b, float c, float d, float res) {
    std::cout.precision(10);
    std::cout << std::setfill('-') << std::setw(211) << '-' << std::endl;

    std::cout << std::setfill(' ') << "|" << std::setw(15) << "a" << std::setw(15) << "|" << std::setw(15) << "b" << std::setw(15) << "|" << 
    std::setw(15) << "c" << std::setw(15) << "|" << std::setw(15) << "d" << std::setw(15) << "|" << std::setw(15) << "f" << std::setw(15) << 
    "|" << std::setw(15) << "g" << std::setw(15) << "|" << std::setw(15) << "result" << std::setw(15) << "|" << std::endl;

    std::cout << std::setfill('-') << std::setw(211) << '-' << std::endl;
    
    std::cout << std::setfill(' ') << "|" << std::setw(15) << a << std::setw(15) << "|" << std::setw(15) << b << std::setw(15) << "|" << 
    std::setw(15) << c << std::setw(15) << "|" << std::setw(15) << d << std::setw(15) << "|" << std::setw(15) << f << std::setw(15) << 
    "|" << std::setw(15) << g << std::setw(15) << "|" << std::setw(15) << res << std::setw(15) << "|" << std::endl;

    std::cout << std::setfill('-') << std::setw(211) << '-' << std::endl << std::endl;

    
}

bool is_in_interval(float num, float delta, float start) {
    float modula = fmod(num - start, delta);
    // std::cout << num - start << " % " << delta << " = " << modula << std::endl;
    return (modula <= delta + 0.01 && modula >= delta - 0.01) || (modula <= 0.01 && modula >= 0.0);
}