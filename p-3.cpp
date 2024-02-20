#include <iostream>
#include <vector>

int main() {
    const int ROWS = 3;
    const int COLS = 5;

    std::vector<std::vector<double>> array(ROWS, std::vector<double>(COLS));


    std::cout << "Введите элементы двумерного массива (3 строки по 5 элементов):\n";
    for (int i = 0; i < ROWS; ++i) {
        std::cout << "Введите " << COLS << " элементов для строки " << i + 1 << ":\n";
        for (int j = 0; j < COLS; ++j) {
            std::cin >> array[i][j];
        }
    }

    std::cout << "Средние арифметические элементов в каждой строке:\n";
    for (int i = 0; i < ROWS; ++i) {
        double rowSum = 0;
        for (int j = 0; j < COLS; ++j) {
            rowSum += array[i][j];
        }
        double rowAverage = rowSum / COLS;
        std::cout << "Строка " << i + 1 << ": " << rowAverage << std::endl;
    }

    return 0;
}
