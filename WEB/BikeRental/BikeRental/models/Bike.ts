import { prop, Typegoose, ModelType, InstanceType } from "typegoose";

export class Bike extends Typegoose {
    @prop()
    name: string;
};
export let bikeModel = new Bike().getModelForClass(Bike);