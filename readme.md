# Testing

> [!WARNING] 
> This is an *intentionally buggy* API/web frontend, to be used as an introduction to testing.

---
The repository is split into 2 parts to allow for a wider range of testing:

1. API
   
This exposes 3 routes - `/login`, `/calculator`, and `/pokemon`. Each has its own quirks and bugs (no spoilers!) that can be investigated via tools like Postman. Click the correct options in the frontend and that will also help you spot some of the issues!


2. Frontend
   
This makes use of the API to display various pieces of information or carry out different actions. Testing can be carried out manually or via automated tools like Selenium