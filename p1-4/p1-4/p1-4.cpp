#include <iostream>
#include <string>
#include <algorithm>
#include <random>
#include <ctime>

// Функция для переворота строки задом наперед
std::string reverse(const std::string& word) {
    std::string reversedWord = word;
    std::reverse(reversedWord.begin(), reversedWord.end());
    return reversedWord;
}

// Функция для удаления гласных из строки
std::string removeVowels(const std::string& word) {
    std::string result = word;
    result.erase(std::remove_if(result.begin(), result.end(), [](char c) {
        return std::string("aeiouAEIOU").find(c) != std::string::npos;
        }), result.end());
    return result;
}

// Функция для удаления согласных из строки
std::string removeConsonants(const std::string& word) {
    std::string result = word;
    result.erase(std::remove_if(result.begin(), result.end(), [](char c) {
        return std::string("bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ").find(c) != std::string::npos;
        }), result.end());
    return result;
}

// Функция для перемешивания символов в строке
std::string shuffle(const std::string& word) {
    std::string shuffledWord = word;
    std::mt19937 gen(time(0));
    std::shuffle(shuffledWord.begin(), shuffledWord.end(), gen);
    return shuffledWord;
}

int main() {
    std::string word;
    std::cout << "Введите слово: ";
    std::cin >> word;

    int choice;
    std::cout << "Выберите действие:" << std::endl;
    std::cout << "1. Слово выводится задом наперед." << std::endl;
    std::cout << "2. Вывести слово без гласных." << std::endl;
    std::cout << "3. Вывести слово без согласных." << std::endl;
    std::cout << "4. Рандомно раскидывать буквы заданного слова." << std::endl;
    std::cin >> choice;

    switch (choice) {
    case 1:
        std::cout << "Результат: " << reverse(word) << std::endl;
        break;
    case 2:
        std::cout << "Результат: " << removeVowels(word) << std::endl;
        break;
    case 3:
        std::cout << "Результат: " << removeConsonants(word) << std::endl;
        break;
    case 4:
        std::cout << "Результат: " << shuffle(word) << std::endl;
        break;
    default:
        std::cout << "Некорректный выбор." << std::endl;
        break;
    }

    return 0;
}

