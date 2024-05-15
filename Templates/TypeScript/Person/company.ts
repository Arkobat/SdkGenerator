import { JsonProperty } from "json-object-mapper";

export class Company {
	@JsonProperty({ required: true })
	public name: string;

	@JsonProperty({ required: true })
	public address: Address;
}
