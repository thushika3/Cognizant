# Angular Debugging Demo

## Objective
Demonstrate debugging techniques in Angular using Chrome DevTools and Visual Studio Code.

## Features
- Student Component
- Student Service
- Add Student
- View Student List
- Debugging with Breakpoints
- DOM Inspection
- Variable Watch

## Tools Used
- Angular 20
- TypeScript
- Visual Studio Code
- Chrome DevTools

## How to Run

```bash
npm install
ng serve
```

Open:

```
http://localhost:4200
```

## Debugging Steps

1. Run the application.
2. Press **F12** to open Chrome DevTools.
3. Inspect the DOM.
4. Open `student.component.ts`.
5. Place a breakpoint inside `addStudent()`.
6. Click **Add Student**.
7. Observe variable values in the VS Code debugger.

## Project Structure

```
src/
 ├── app/
 │   ├── app.component.ts
 │   ├── app.module.ts
 │   ├── student/
 │   └── services/
 ├── main.ts
 └── styles.css
```

## Author

Your Name
