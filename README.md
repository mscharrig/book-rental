# Interview Guidelines
- Ensure that you fully understand the given task or question.
- Don't hesitate to ask questions if you encounter challenges or need additional information.
- You are allowed to use online resources, including search engines like Google, during the interview.
    - If you do so, please share the research process with us.
- And most importantly, be vocal about your thought process throughout the interview.

# Setup
- Either download the source code from this repository or check it out via GIT.
- Open the code in your preferred IDE.
- Launch the application and perform a test request to the API of the **BookRental.Api project** using Postman or another tool of your choice.

# Tasks
## 1. Implement an endpoint to rent books 
In the **BookRental.Api** project, create an API endpoint to rent a book for a user, enforcing validation rules such as availability and updating both the book and rental records accordingly.

#### Functional requirements:
- The endpoint must allow a user to rent a specific book.
- A book can only be rented if it is currently available (i.e., not already rented by someone else).
- If the book is already rented, the API should return an error response with an appropriate message.
- When a book is successfully rented:
  - The book’s IsRented flag should be set to true.
  - A new rental record should be created.

#### Technical requirements:
- The "BookStore" class acts as a mock database. Use it to retrieve and store data.
- On success, return the created rental record.
- Handle possible failure cases and return an appropriate HTTP status code with a meaningful error message.

## 2. Implement an endpoint to return books
In the **BookRental.Api** project, implement a return API endpoint that calculates dynamic late fees and condition-based penalties, updates the book’s availability, and returns a detailed fee summary.

#### Functional requirements:
- When a user returns a book, the API must calculate rental duration and fees:
  - First 7 days free
  - Day 8–14: 1€/day
  - Day 15–21: 2€/day
  - Day 22+: 5€/day
- Introduce book condition penalties:
  - The request should include an optional bookCondition field (good, damaged, lost). Apply additional fees for the following conditions:
  - good: no fee and mark the book as rentable again
  - damaged: +5€ fee
  - lost: +20€ fee, mark the book as unavailable
- Only the user who rented the book can return it.

#### Technical requirements:
- On success, return the number of days rented and the calculated fees. The response must include:
  - Days rented
  - Which fees were applied
- Additionally, the rental fees, duration, condition and penalties should be stored in the "BookStore" database
- The calculation logic should be unit-testable
- Handle possible failure cases and return an appropriate HTTP status code with a meaningful error message.

## 3. Refactor the Legacy Payment Processor
Analyze and refactor the **LegacyPaymentProcessing** project, which tightly couples business logic with third-party dependencies. Your goal is to make the codebase cleaner, testable, and extensible.

### Functional requirements:
- The application should continue to support processing and refunding payments for:
  - Credit Card
  - PayPal
  - Crypto
- Behavior must remain the same from a user perspective (i.e., same console output sequence is acceptable).

### Technical requirements:
- Refactor the payment processor by applying SOLID and DRY principles.
- Avoid code duplication and excessive branching.
- Introduce abstractions where appropriate.
- Code should be easy to test and extend (e.g., add ApplePay later).
- Keep in mind that you cannot change the code of the **PaymentApiClient**
