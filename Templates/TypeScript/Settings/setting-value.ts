import { JsonProperty } from "json-object-mapper";

export class SettingValue<T> {
	@JsonProperty({ name: "inherited" })
	public inherited: boolean;

	@JsonProperty({ required: true })
	public value: T;
}

export class ToggleableSetting<T> extends SettingValue<T> {
	@JsonProperty({ required: true })
	public enabled: boolean;
}

export class NullableSettingValue<T> {
	@JsonProperty({ name: "inherited" })
	public inherited: boolean;

	@JsonProperty({ required: false })
	public value?: T;

	public hasValue(): boolean {
		return this.value !== undefined;
	}
}

export class NullableToggleableSetting<T> extends NullableSettingValue<T> {
	@JsonProperty({ required: true })
	public enabled: boolean;

	public computedValue(): T | undefined {
		return this.enabled ? this.value : undefined;
	}
	//TODO: Figure out default value
	//public T? ComputedValue() => Enabled ? Value : default;
}
