#include <iostream>
#include <string>
#include <Windows.h>

using namespace std;

class BankAccount {

private:
    int accountNumber;
    double balance;
    double interestRate;
public:
    BankAccount(int accNum, double initialBalance) : accountNumber(accNum), balance(initialBalance), interestRate(0) {
        setlocale(LC_ALL, "Russian");
        if (initialBalance < 0) {
            throw invalid_argument("Начальный баланс не может быть отрицательным");
        }
    }

    void deposit(double amount) {
        setlocale(LC_ALL, "Russian");
        if (amount <= 0) {
            throw invalid_argument("Некорректная сумма для внесения");
        }
        balance += amount;
        cout << "Средства успешно внесены. Остаток на счете: " << balance << endl;
    }

    void withdraw(double amount) {
        setlocale(LC_ALL, "Russian");
        if (amount <= 0) {
            throw invalid_argument("Некорректная сумма для снятия");
        }
        if (amount > balance) {
            throw invalid_argument("Недостаточно средств");
        }
        balance -= amount;
        cout << "Средства успешно сняты. Остаток на счете: " << balance << endl;
    }

    double getBalance() {
        setlocale(LC_ALL, "Russian");
        return balance;
    }

    double getInterest() {
        setlocale(LC_ALL, "Russian");
        return balance * interestRate * (1.0 / 12.0);
    }

    void setInterestRate(double rate) {
        setlocale(LC_ALL, "Russian");
        interestRate = rate;
    }

    int getAccountNumber() {
        setlocale(LC_ALL, "Russian");
        return accountNumber;
    }

    friend bool transfer(BankAccount& from, BankAccount& to, double amount) {
        setlocale(LC_ALL, "Russian");
        try {
            from.withdraw(amount);
            to.deposit(amount);
            return true;
        }
        catch (const invalid_argument& e) {
            cerr << "Ошибка при переводе: " << e.what() << endl;
            return false;
        }
    }
};

int main() {
    setlocale(LC_ALL, "RUS");
    try {
        BankAccount google(1, 0);
        BankAccount apple(2, 0);

        int choice;
        double amount;
        bool success;
        setlocale(LC_ALL, "Russian");

        while (true) {
            cout << "Выберите действие:\n"
                "1. Пополнить счет\n"
                "2. Снять деньги\n"
                "3. Изменить процентную ставку\n"
                "4. Перевод\n"
                "5. Узнать текущую процентную ставку\n"
                "6. Получить номер банковского счета\n"
                "7. Выход из программы\n";
            cin >> choice;

            switch (choice) {
            case 1:
                cout << "Введите сумму пополнения: ";
                cin >> amount;
                google.deposit(amount);
                break;
            case 2:
                cout << "Введите сумму для снятия: ";
                cin >> amount;
                google.withdraw(amount);
                break;
            case 3:
                cout << "Введите новую процентную ставку: ";
                cin >> amount;
                google.setInterestRate(amount);
                break;
            case 4:
                cout << "Перевод между счетами\n";
                cout << "Введите сумму для перевода: ";
                cin >> amount;
                success = transfer(google, apple, amount);
                if (success) {
                    cout << "Перевод выполнен успешно." << endl;
                }
                break;
            case 5:
                cout << "Текущая процентная ставка: " << google.getInterest() << "%" << endl;
                break;
            case 6:
                cout << "Номер банковского счета: " << google.getAccountNumber() << endl;
                break;
            case 7:
                cout << "Выход из программы." << endl;
                return 0;
            default:
                cout << "Ошибка: Неверный выбор. Выберите действие из списка." << endl;
            }
        }
    }
    catch (const invalid_argument& e) {
        cerr << "Ошибка: " << e.what() << endl;
    }


    return 0;
}

