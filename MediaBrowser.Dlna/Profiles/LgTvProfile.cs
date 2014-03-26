﻿using System.Xml.Serialization;
using MediaBrowser.Controller.Dlna;

namespace MediaBrowser.Dlna.Profiles
{
    [XmlRoot("Profile")]
    public class LgTvProfile : DefaultProfile
    {
        public LgTvProfile()
        {
            Name = "LG Smart TV";

            TimelineOffsetSeconds = 10;

            Identification = new DeviceIdentification
            {
                FriendlyName = @"LG.*",

                Headers = new[]
               {
                   new HttpHeaderInfo
                   {
                       Name = "User-Agent",
                       Value = "LG",
                       Match = HeaderMatchType.Substring
                   }
               }
            };

            TranscodingProfiles = new[]
           {
               new TranscodingProfile
               {
                   Container = "mp3",
                   AudioCodec = "mp3",
                   Type = DlnaProfileType.Audio
               },
               new TranscodingProfile
               {
                   Container = "ts",
                   AudioCodec = "ac3",
                   VideoCodec = "h264",
                   Type = DlnaProfileType.Video
               },
               new TranscodingProfile
               {
                   Container = "jpeg",
                   Type = DlnaProfileType.Photo
               }
           };

            DirectPlayProfiles = new[]
            {
                new DirectPlayProfile
                {
                    Container = "ts",
                    VideoCodec = "h264",
                    AudioCodec = "aac,ac3,mp3",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "mkv",
                    VideoCodec = "h264",
                    AudioCodec = "aac,ac3,mp3",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "mp4",
                    VideoCodec = "h264,mpeg4",
                    AudioCodec = "aac,ac3,mp3",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "mp3",
                    AudioCodec = "mp3",
                    Type = DlnaProfileType.Audio
                },
                new DirectPlayProfile
                {
                    Container = "jpeg",
                    Type = DlnaProfileType.Photo
                }
            };

            ContainerProfiles = new[]
            {
                new ContainerProfile
                {
                    Type = DlnaProfileType.Photo,

                    Conditions = new []
                    {
                        new ProfileCondition
                        {
                            Condition = ProfileConditionType.LessThanEqual,
                            Property = ProfileConditionValue.Width,
                            Value = "1920"
                        },
                        new ProfileCondition
                        {
                            Condition = ProfileConditionType.LessThanEqual,
                            Property = ProfileConditionValue.Height,
                            Value = "1080"
                        }
                    }
                }
            };

            CodecProfiles = new[]
           {
               new CodecProfile
               {
                   Type = CodecType.VideoCodec,
                   Codec = "mpeg4",

                   Conditions = new[]
                   {
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.Width,
                           Value = "1920"
                       },
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.Height,
                           Value = "1080"
                       },
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.VideoFramerate,
                           Value = "30"
                       }
                   }
               },

               new CodecProfile
               {
                   Type = CodecType.VideoCodec,
                   Codec = "h264",

                   Conditions = new[]
                   {
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.Width,
                           Value = "1920"
                       },
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.Height,
                           Value = "1080"
                       },
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.VideoFramerate,
                           Value = "30"
                       },
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.VideoLevel,
                           Value = "41"
                       }
                   }
               },

               new CodecProfile
               {
                   Type = CodecType.VideoAudioCodec,
                   Codec = "ac3,aac,mp3",

                   Conditions = new[]
                   {
                       new ProfileCondition
                       {
                           Condition = ProfileConditionType.LessThanEqual,
                           Property = ProfileConditionValue.AudioChannels,
                           Value = "6"
                       }
                   }
               }
           };
        }
    }
}
