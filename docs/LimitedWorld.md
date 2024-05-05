# VRChat.API.Model.LimitedWorld

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**AuthorName** | **string** |  | [optional] 
**Capacity** | **int** |  | [optional] 
**RecommendedCapacity** | **int** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**Favorites** | **int** |  | [optional] [default to 0]
**Visits** | **int** |  | [optional] [default to 0]
**Heat** | **int** |  | [optional] [default to 0]
**Id** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | [optional] 
**ImageUrl** | **string** |  | [optional] 
**LabsPublicationDate** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Occupants** | **int** |  | [optional] [default to 0]
**Organization** | **string** |  | [optional] [default to "vrchat"]
**Popularity** | **int** |  | [optional] [default to 0]
**PreviewYoutubeId** | **string** |  | [optional] 
**PublicationDate** | **string** |  | [optional] 
**ReleaseStatus** | **ReleaseStatus** |  | [optional] 
**Tags** | **List&lt;string&gt;** |   | [optional] 
**ThumbnailImageUrl** | **string** |  | [optional] 
**UnityPackages** | [**List&lt;LimitedUnityPackage&gt;**](LimitedUnityPackage.md) |   | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**UdonProducts** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

