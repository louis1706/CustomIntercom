# CustomIntercom

This plugin make possible to customise the IntercomText on your server it's will be actualise every tick

This plugin use [CommandInterpolation](https://en.scpslgame.com/index.php?title=Command_Interpolation
) it's permit you to make custom text who can change with with what is happening on the server

whe have add just some CommandInterpolation for Intercom

# Commands
|     CommandInterpolation    | ReturnValue | Description |
| :-------------: | :---------: | :--------- |
| intercom_speech_remaining_time | Int | The remaining speech time of the player to talk at intercom_bypass_speaking. |
| intercom_remaining_cooldown | Int | The waiting time to talk again at intercom |
| intercom_speaker_nickname | String | The nickname of the player at intercom |
| intercom_is_in_use | Bool | Is the intercom being used |
| intercom_is_admin_speaking | Bool | Is an admin who speak at intercom |
| intercom_bypass_speaking | Bool | The player who speak at intercom have bypass |
| intercom_mute_player_speak | Bool | The player who actually trying to talk is muted |
