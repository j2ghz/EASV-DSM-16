import { prop, Typegoose, ModelType, InstanceType } from "typegoose";

export class Bike extends Typegoose {
    @prop()
    id: number;
    @prop()
    name: string;
    @prop()
    modelId: number;
};
export let bikeModel = new Bike().getModelForClass(Bike);