const express = require("express");
const app = express();


app.get("/users", ( req, res ) => {

  const users = [
    { _id: 1, username: "adreye0", email: "adreye0@independent.co.uk", password: "feMyfHmdiR", firstname: "Antonetta", lastname:  "Dreye",  genre: "M", age: 25, birthdate: "2022-12-10 00:00:00.000",   verified: true},
    { _id: 2, username: "dbrownscombe1", email: "dbrownscombe1@yale.edu",  password: "NR53RA", firstname: "Davine" , lastname:  "Brownscombe",  genre: "M", age: 34, birthdate: "2022-05-15 00:00:00.000",   verified: false},
    { _id: 3, username: "brustan2", email:  "brustan2@trellian.com", password: "Js1ilvqB1NOK", firstname: "Bail" , lastname:  "Rustan",   genre: "F", age: 30, birthdate: "2023-01-31 00:00:00.000",   verified: true},
    { _id: 4, username: "dmcwhinnie3", email: "dmcwhinnie3@weather.com", password: "Uxp3qxbnbtKr", firstname: "Daryle" , lastname:  "McWhinnie",  genre: "M", age: 56, birthdate: "2022-04-05 00:00:00.000",   verified: false},
    { _id: 5, username: "vpretti4", email:  "vpretti4@yelp.com", password: "rkyiOqcPx", firstname: "Vivienne" , lastname:  "Pretti",   genre: "F", age: 20, birthdate: "2022-04-26 00:00:00.000",   verified: true},
    { _id: 6, username: "gwaryk5", email: "gwaryk5@deliciousdays.com", password: "JpGlFT44", firstname: "Gweneth", lastname:  "Waryk",  genre: "M", age: 19, birthdate: "2023-02-10 00:00:00.000",   verified: true},
    { _id: 7, username: "xhaysham6", email: "xhaysham6@cdc.gov", password: "4GUdKCIMde", firstname: "Xenia", lastname:  "Haysham",  genre: "M", age: 27, birthdate: "2022-12-20 00:00:00.000",   verified: false},
    { _id: 8, username: "sfrail7", email: "sfrail7@51.la", password: "BZpfvlLCr", firstname: "Storm", lastname:  "Frail",  genre: "M", age: 28, birthdate: "2022-10-15 00:00:00.000",   verified: false},
    { _id: 9, username: "tpalin8", email: "tpalin8@tripod.com",  password: "RysKEhvXmF", firstname: "Tomas", lastname:  "Palin",  genre: "F", age: 37, birthdate: "2022-12-17 00:00:00.000",   verified: false},
    { _id: 10, username: "rdenholm9", email: "rdenholm9@ow.ly", password: "iC95Rtp", firstname: "Rebeca" , lastname:  "Denholm",  genre: "M", age: 49, birthdate: "2022-03-07 00:00:00.000",   verified: false},
    { _id: 11, username: "vshaxbya", email:  "vshaxbya@statcounter.com",  password: "tt5V46Y", firstname: "Vania", lastname:  "Shaxby",   genre: "F", age: 29, birthdate: "2022-03-21 00:00:00.000",   verified: true},
    { _id: 12, username: "larranb", email: "larranb@naver.com", password: "oVJNwVrl", firstname: "Lodovico" , lastname:  "Arran",  genre: "M", age: 34, birthdate: "2022-06-18 00:00:00.000",   verified: false},
    { _id: 13, username: "cfrancesc", email: "cfrancesc@ning.com",  password: "UpTVbY9lSgj", firstname: "Chrissy", lastname:  "Frances",  genre: "F", age: 37, birthdate: "2022-12-11 00:00:00.000",   verified: true},
    { _id: 14, username: "spaprotnyd", email:  "spaprotnyd@trellian.com", password: "Ol774cmpOkd", firstname: "Samson" , lastname:  "Paprotny",   genre: "M", age: 42, birthdate: "2022-11-16 00:00:00.000",   verified: false},
    { _id: 15, username: "mfouche", email: "mfouche@amazon.de", password: "Nps1pmal", firstname: "Michell", lastname:  "Fouch",  genre: "F", age: 41, birthdate: "2023-01-01 00:00:00.000",   verified: false},
    { _id: 16, username: "rnolif", email:  "rnolif@nba.com",  password: "fJ8IUj5", firstname: "Rici" , lastname:  "Noli",   genre: "M", age: 46, birthdate: "2022-05-05 00:00:00.000",   verified: false},
    { _id: 17, username: "gbeausangg", email:  "gbeausangg@pbs.org",  password: "wiLgGoDj", firstname: "Glen" , lastname:  "Beausang",   genre: "F", age: 21, birthdate: "2022-08-28 00:00:00.000",   verified: false},
    { _id: 18, username: "pcolloffh", email: "pcolloffh@aol.com", password: "GrUmCN", firstname: "Patrica", lastname:  "Colloff",  genre: "M", age: 25, birthdate: "2022-05-26 00:00:00.000",   verified: false},
    { _id: 19, username: "lbretoni", email:  "lbretoni@taobao.com", password: "hF9dWGBd1", firstname: "Lurette", lastname:  "Breton",   genre: "F", age: 18, birthdate: "2023-01-10 00:00:00.000",   verified: true},
    { _id: 20, username: "mmoroj", email:  "mmoroj@about.me", password: "9HG6FLV3C", firstname: "Mellicent", lastname:  "Moro",   genre: "M", age: 65, birthdate: "2022-06-20 00:00:00.000",   verified: false}
  ];

  res.json(users);
});

app.get("/products", (req, res) => {
  res.json({
    HDR: [
      {
        Id_Transaccion: "000001",
        FechaCreacion: '2023-04-14T02:47:39.099Z',
        CodSucursalOrigen: "VLN",
        CodAlmacenOrigen: "VLN-01",
        CodSucursalDestino: "SNC",
        CodAlmacenDestino: "SNC-01"
      }
    ],

    LINE: [
      { Id_Transaccion: "000001", CodArticulo: "JJLM-002", Cantidad: 3, Marca: "XIAOMI", Disponible: true, Precio: 34.568900 },
      { Id_Transaccion: "000001", CodArticulo: "JJLM-003", Cantidad: 5, Marca: "SAMSUNG", Disponible: true, Precio: 76.164300 },
      { Id_Transaccion: "000001", CodArticulo: "JJLM-004", Cantidad: 8, Marca: "MOTOROLA", Disponible: false, Precio: 23.568980 }
    ]
  })
});

app.listen(8000, () => {
  console.log("Server running at: 'http://localhost:8000/'");
});

