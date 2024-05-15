import { JsonProperty } from "json-object-mapper";
import {
	NullableSettingValue,
	NullableToggleableSetting,
	SettingValue,
	ToggleableSetting,
} from "./setting-value";
import { TimeSetting } from "./time-setting";
import { ButtonDto } from "./button-dto";

export class SimpleSettingDto {
	@JsonProperty({ required: true })
	public settingId: string;

	@JsonProperty({ required: true })
	public serverId: string;

	@JsonProperty({ required: true })
	public name: string;
}

export class SettingDto extends SimpleSettingDto {
	@JsonProperty({ required: false })
	public inheritsFrom?: string;

	@JsonProperty({ required: true })
	public index: number;

	@JsonProperty({ required: true })
	public state: string;

	@JsonProperty({ required: true })
	public active: string;

	@JsonProperty({ required: true })
	public displayName: SettingValue<string>;

	@JsonProperty({ required: true })
	public roles: SettingValue<string[]>;

	@JsonProperty({ required: true })
	public categories: Categories;

	@JsonProperty({ required: true })
	public permissions: Permissions;

	@JsonProperty({ required: true })
	public messages: Messages;

	@JsonProperty({ required: true })
	public automation: Automation;

	@JsonProperty({ required: true })
	public buttons: Buttons;

	@JsonProperty({ required: true })
	public limitations: Limitations;

	@JsonProperty({ required: true })
	public logging: Logging;

	@JsonProperty({ required: true })
	public files: FileSettings;
}

export class Categories {
	@JsonProperty({ required: true })
	public queue: SettingValue<SettingCategory[]>;

	@JsonProperty({ required: true })
	public active: SettingValue<SettingCategory[]>;

	@JsonProperty({ required: true })
	public done: SettingValue<SettingCategory[]>;

	@JsonProperty({ required: true })
	public autoMoveAround: SettingValue<boolean>;
}

class SettingCategory {
	@JsonProperty()
	public categoryId: string;

	@JsonProperty()
	public selfCreated: boolean;
}

export class Permissions {
	@JsonProperty({ required: true })
	public queuePermissions: SettingValue<PermissionBits>;

	@JsonProperty({ required: true })
	public activePermissions: SettingValue<PermissionBits>;

	@JsonProperty({ required: true })
	public donePermissions: SettingValue<PermissionBits>;
}

//FIXME: Number cannot hold ulong
export class PermissionBits {
	@JsonProperty({ required: true })
	public allow: number;

	@JsonProperty({ required: true })
	public deny: number;
}

export class Messages {
	@JsonProperty({ required: true })
	public welcomeMessage: NullableToggleableSetting<string>;

	@JsonProperty({ required: true })
	public closeMessage: NullableToggleableSetting<string>;
}

export class Automation {
	@JsonProperty({ required: true })
	public notifyUser: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public requireCloseReason: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public notifyClaimer: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public closeOnLeave: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public closeDelay: ToggleableSetting<TimeSetting>;

	@JsonProperty({ required: true })
	public autoCloseWarning: ToggleableSetting<TimeSetting>;

	@JsonProperty({ required: true })
	public autoCloseTime: ToggleableSetting<TimeSetting>;
}

export class Buttons {
	@JsonProperty({ required: true })
	public closeButton: NullableToggleableSetting<ButtonDto>;

	@JsonProperty({ required: true })
	public claimButton: NullableToggleableSetting<ButtonDto>;

	@JsonProperty({ required: true })
	public cancelCloseButton: NullableToggleableSetting<ButtonDto>;

	@JsonProperty({ required: true })
	public closeNowButton: NullableToggleableSetting<ButtonDto>;
}

export class Limitations {
	@JsonProperty({ required: true })
	public maxActivePerUser: ToggleableSetting<number>;

	@JsonProperty({ required: true })
	public maxActiveTotal: ToggleableSetting<number>;

	@JsonProperty({ required: true })
	public cooldown: ToggleableSetting<TimeSetting>;

	@JsonProperty({ required: false })
	public whitelist: SettingValue<Whitelist>;
}

export class Whitelist {
	@JsonProperty({ required: true })
	public inverted: boolean;

	@JsonProperty({ required: true })
	public ids: string[];
}

export class Logging {
	@JsonProperty({ required: true })
	public channelId: NullableSettingValue<string>;

	@JsonProperty({ required: true })
	public rainbowColors: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public created: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public claimed: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public deleted: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public memberAdded: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public memberRemoved: SettingValue<boolean>;

	@JsonProperty({ required: true })
	public subjectChanged: SettingValue<boolean>;
}

export class FileSettings {
	@JsonProperty({ required: true })
	public storageExceeded: SettingValue<StorageExceededAction>;

	@JsonProperty({ required: true })
	public retentionTime: ToggleableSetting<TimeSetting>;
}

export enum StorageExceededAction {
	Reject,
	Inform,
	DeleteOldestFileSameSubject,
	DeleteOldestFileGlobal,
}
