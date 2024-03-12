extends Node

func _ready():
	DiscordSDK.app_id = 1214066608113188884
	DiscordSDK.state = "testing"
	DiscordSDK.details = "Currently Testing Project Dim"
	DiscordSDK.large_image = "normalsinklogo"
	DiscordSDK.refresh()
