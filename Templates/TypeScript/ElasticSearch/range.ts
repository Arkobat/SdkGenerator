import { JsonProperty } from "json-object-mapper";

export abstract class Range {}

export class DateRange extends Range {
	@JsonProperty({ name: "gt" })
	public greaterThan: Date;

	@JsonProperty({ name: "gte" })
	public greaterThanOrEqualTo: Date;

	@JsonProperty({ name: "lt" })
	public lessThan: Date;

	@JsonProperty({ name: "lte" })
	public lessThanOrEqualTo: Date;
}

//Does not really make sense to have ranges for number types since they are all the same
// but they are included for completeness :)
export class DoubleRange extends Range {
	@JsonProperty({ name: "gt" })
	public greaterThan: number;

	@JsonProperty({ name: "gte" })
	public greaterThanOrEqualTo: number;

	@JsonProperty({ name: "lt" })
	public lessThan: number;

	@JsonProperty({ name: "lte" })
	public lessThanOrEqualTo: number;
}

export class FloatRange extends Range {
	@JsonProperty({ name: "gt" })
	public greaterThan: number;

	@JsonProperty({ name: "gte" })
	public greaterThanOrEqualTo: number;

	@JsonProperty({ name: "lt" })
	public lessThan: number;

	@JsonProperty({ name: "lte" })
	public lessThanOrEqualTo: number;
}

export class IntegerRange extends Range {
	@JsonProperty({ name: "gt" })
	public greaterThan: number;

	@JsonProperty({ name: "gte" })
	public greaterThanOrEqualTo: number;

	@JsonProperty({ name: "lt" })
	public lessThan: number;

	@JsonProperty({ name: "lte" })
	public lessThanOrEqualTo: number;
}

export class LongRange extends Range {
	@JsonProperty({ name: "gt" })
	public greaterThan: number;

	@JsonProperty({ name: "gte" })
	public greaterThanOrEqualTo: number;

	@JsonProperty({ name: "lt" })
	public lessThan: number;

	@JsonProperty({ name: "lte" })
	public lessThanOrEqualTo: number;
}

export class IpAddressRange extends Range {
	@JsonProperty({ name: "gt" })
	public greaterThan: string;

	@JsonProperty({ name: "gte" })
	public greaterThanOrEqualTo: string;

	@JsonProperty({ name: "lt" })
	public lessThan: string;

	@JsonProperty({ name: "lte" })
	public lessThanOrEqualTo: string;
}
