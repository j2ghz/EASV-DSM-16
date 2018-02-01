import express = require("express"); //TODO: should be import express from "express"
import { Application } from "express";
import routes from "./routes";
import * as mongoose from "mongoose";
import { json, urlencoded } from "body-parser";

mongoose.connect("mongo://localhost:27017/BikeRental");
mongoose.set("debug", true);

const app: Application = express();

app.use(json());
app.use(urlencoded({
    extended: true
}));

app.use("/", routes);

app.listen(process.env.port || 1337,
    () => {
        console.log("Listening");
    });