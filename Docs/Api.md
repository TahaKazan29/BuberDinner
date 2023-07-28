# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "firstName": "Taha Kazan",
  "lastName": "Mantinband",
  "email": "tahakazantk@gmail.com",
  "password": "Amiko1232!"
}
```

#### Login Response

```json
{
  "id": "d89c2d9a-eb3e-4875-95ff-b920655aa104",
  "firstName": "Taha Kazan",
  "lastName": "Mantinband",
  "email": "tahakazantk@gmail.com",
  "token": "eyJhb..hbbQ"
}
```
