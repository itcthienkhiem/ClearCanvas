#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Collections.Generic;
    using ClearCanvas.ImageServer.Model.EntityBrokers;
    using ClearCanvas.ImageServer.Enterprise;
    using System.Reflection;

[Serializable]
public partial class ServerRuleTypeEnum : ServerEnum
{
      #region Private Static Members
      private static readonly ServerRuleTypeEnum _AutoRoute = GetEnum("AutoRoute");
      private static readonly ServerRuleTypeEnum _StudyDelete = GetEnum("StudyDelete");
      private static readonly ServerRuleTypeEnum _Tier1Retention = GetEnum("Tier1Retention");
      private static readonly ServerRuleTypeEnum _OnlineRetention = GetEnum("OnlineRetention");
      private static readonly ServerRuleTypeEnum _StudyCompress = GetEnum("StudyCompress");
      private static readonly ServerRuleTypeEnum _SopCompress = GetEnum("SopCompress");
      private static readonly ServerRuleTypeEnum _DataAccess = GetEnum("DataAccess");
      private static readonly ServerRuleTypeEnum _StudyQualityControl = GetEnum("StudyQualityControl");
      private static readonly ServerRuleTypeEnum _StudyAutoRoute = GetEnum("StudyAutoRoute");
      #endregion

      #region Public Static Properties
      /// <summary>
      /// A DICOM auto-routing rule
      /// </summary>
      public static ServerRuleTypeEnum AutoRoute
      {
          get { return _AutoRoute; }
      }
      /// <summary>
      /// A rule to specify when to delete a study
      /// </summary>
      public static ServerRuleTypeEnum StudyDelete
      {
          get { return _StudyDelete; }
      }
      /// <summary>
      /// A rule to specify how long a study will be retained on Tier1
      /// </summary>
      public static ServerRuleTypeEnum Tier1Retention
      {
          get { return _Tier1Retention; }
      }
      /// <summary>
      /// A rule to specify how long a study will be retained online
      /// </summary>
      public static ServerRuleTypeEnum OnlineRetention
      {
          get { return _OnlineRetention; }
      }
      /// <summary>
      /// A rule to specify when a study should be compressed
      /// </summary>
      public static ServerRuleTypeEnum StudyCompress
      {
          get { return _StudyCompress; }
      }
      /// <summary>
      /// A rule to specify when a SOP Instance should be compressed (during initial processing)
      /// </summary>
      public static ServerRuleTypeEnum SopCompress
      {
          get { return _SopCompress; }
      }
      /// <summary>
      /// A rule to specify the Authority Groups that have access to a study
      /// </summary>
      public static ServerRuleTypeEnum DataAccess
      {
          get { return _DataAccess; }
      }
      /// <summary>
      /// A rule for quality control purposes when studies are received
      /// </summary>
      public static ServerRuleTypeEnum StudyQualityControl
      {
          get { return _StudyQualityControl; }
      }
      /// <summary>
      /// A DICOM auto-routing rule for studies
      /// </summary>
      public static ServerRuleTypeEnum StudyAutoRoute
      {
          get { return _StudyAutoRoute; }
      }

      #endregion

      #region Constructors
      public ServerRuleTypeEnum():base("ServerRuleTypeEnum")
      {}
      #endregion
      #region Public Members
      public override void SetEnum(short val)
      {
          ServerEnumHelper<ServerRuleTypeEnum, IServerRuleTypeEnumBroker>.SetEnum(this, val);
      }
      static public List<ServerRuleTypeEnum> GetAll()
      {
          return ServerEnumHelper<ServerRuleTypeEnum, IServerRuleTypeEnumBroker>.GetAll();
      }
      static public ServerRuleTypeEnum GetEnum(string lookup)
      {
          return ServerEnumHelper<ServerRuleTypeEnum, IServerRuleTypeEnumBroker>.GetEnum(lookup);
      }
      #endregion
}
}
