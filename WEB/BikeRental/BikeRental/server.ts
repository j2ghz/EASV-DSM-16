import express from "express";
import routes from "./routes";
import * as db from "mongoose";

db.connect("mongo://localhost:27017/BikeRental");

let app = express();
app.use("/", routes);
app.listen(process.env.port || 1337);
