// Функция для сложения
function add(a, b) {
    return a + b;
  }
  
  // Функция для вычитания
  function subtract(a, b) {
    return a - b;
  }
  
  // Функция для умножения
  function multiply(a, b) {
    return a * b;
  }
  
  // Функция для деления
  function divide(a, b) {
    if (b === 0) {
      return "На ноль делить нельзя";
    }
    return a / b;
  }
  
  // Пример использования
  let num1 = 10;
  let num2 = 5;
  
  console.log("Сумма:", add(num1, num2));
  console.log("Разность:", subtract(num1, num2));
  console.log("Произведение:", multiply(num1, num2));
  console.log("Частное:", divide(num1, num2));
  
  