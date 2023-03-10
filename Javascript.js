const maxGuesses = 10;
let randomNumber = getRandomNumber();
let numGuesses = 0;

console.log("Guess the random number between 1 and 100.");

while (numGuesses < maxGuesses) {
  const input = prompt("Enter your guess:");

  const guess = parseInt(input);

  if (isNaN(guess) || guess < 1 || guess > 100) {
    console.log("Invalid input. Please enter a number between 1 and 100.");
    continue;
  }

  numGuesses++;

  if (guess === randomNumber) {
    console.log(`Congratulations! You guessed the number in ${numGuesses} tries.`);
    break;
  } else if (guess < randomNumber) {
    console.log("Too low. Try again.");
  } else {
    console.log("Too high. Try again.");
  }
}

if (numGuesses === maxGuesses) {
  console.log(`Sorry, you ran out of guesses. The number was ${randomNumber}.`);
}

function getRandomNumber() {
  return Math.floor(Math.random() * 100) + 1;
}
