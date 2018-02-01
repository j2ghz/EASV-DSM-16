import express from "express";
import { Request, Response, NextFunction, Application } from "express";
import routes from "./routes";
import db from "mongoose";
import { json, urlencoded } from "body-parser";

db.connect("mongo://localhost:27017/BikeRental");

const app: Application = express();

app.use(json());
app.use(urlencoded({
    extended: true
}));

app.use("/", routes);

app.listen(process.env.port || 1337, () => {
    console.log("Listening");
});
