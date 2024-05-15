import { JsonProperty } from "json-object-mapper";

export class ButtonDto {
	@JsonProperty()
	public buttonId: string;

	@JsonProperty()
	public text?: string;

	@JsonProperty()
	public url?: string;

	@JsonProperty()
	public style: ButtonStyle;

	@JsonProperty()
	public emote: ButtonEmote;
}

export class ButtonEmote {
	@JsonProperty()
	public id?: string;

	@JsonProperty()
	public name: string;

	@JsonProperty()
	public animated: boolean;
}

export enum ButtonStyle {
	Primary = 1,
	Secondary = 2,
	Success = 3,
	Danger = 4,
	Link = 5,
}
