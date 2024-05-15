import { JsonProperty } from "json-object-mapper";

export class TimeSetting {
	@JsonProperty({ required: true })
	public time: number;

	@JsonProperty({ required: true })
	public timeUnit: TimeUnit;

	public totalSeconds(): number {
		return this.time * this.timeUnit;
	}
}

export enum TimeUnit {
	Second = 1,
	Minute = Second * 60,
	Hour = Minute * 60,
	Day = Hour * 24,
}
