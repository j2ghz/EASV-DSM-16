import express = require("express"); //TODO: should be import express from "express"
import { Application } from "express";
import routes from "./routes";
import {set, connect} from "mongoose";
import { json, urlencoded } from "body-parser";

connect("mongo://localhost:27017/BikeRental");
set("debug", true);

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