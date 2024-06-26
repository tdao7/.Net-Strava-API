﻿#region Copyright (C) 2014 Sascha Simon

//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see http://www.gnu.org/licenses/.
//
//  Visit the official homepage at http://www.sascha-simon.com

#endregion

using System;
using com.strava.v3.api.Activities;
using Newtonsoft.Json;

namespace com.strava.v3.api.Segments
{
    /// <summary>
    /// Represents a Strava segment.
    /// </summary>
    public class Segment : SegmentSummary
    {
        /// <summary>
        /// The date when the segment was created.
        /// </summary>
        [JsonProperty("created_at")]
        public String CreatedAt { get; set; }

        /// <summary>
        /// The date when the segment was updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public String UpdatedAt { get; set; }

        /// <summary>
        /// The total elevation gain of the segment.
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float TotalElevationGain { get; set; }

        /// <summary>
        /// A map with the segment's route.
        /// </summary>
        [JsonProperty("map")]
        public Map Map { get; set; }

        /// <summary>
        /// The effort count.
        /// </summary>
        [JsonProperty("effort_count")]
        public int EffortCount { get; set; }

        /// <summary>
        /// The number of athletes that run or rode this segment.
        /// </summary>
        [JsonProperty("athlete_count")]
        public int AthleteCount { get; set; }

        /// <summary>
        /// True if the segment was marked as hazardous.
        /// </summary>
        [JsonProperty("hazardous")]
        public Boolean IsHazardous { get; set; }

        /// <summary>
        /// The personal record time.
        /// </summary>
        [JsonProperty("pr_time")]
        public int PersonalRecordTime { get; set; }

        /// <summary>
        /// The personal record distance.
        /// </summary>
        [JsonProperty("pr_distance")]
        public float PersonalRecordDistance { get; set; }

        /// <summary>
        /// Number of stars on this segment. 
        /// </summary>
        [JsonProperty("star_count")]
        public int StarCount { get; set; }
    }
}
