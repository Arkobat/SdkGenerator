import { JsonProperty } from "json-object-mapper";

export class Address {
	@JsonProperty({ name: "street_name", required: true })
	public streetName: string;

	@JsonProperty({ required: true })
	public number: number;
}
