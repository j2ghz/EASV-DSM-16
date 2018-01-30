import * as express from "express";
import routes from "./routes";
import { MongoClient } from "mongodb";

let app = express();
app.use("/", routes);
app.listen(process.env.port || 1337);

//MongoClient.connect("mongo:/localhost:27017/", (err, db) => {
//    db.db("BikeRental").collection("bikes")
//} );