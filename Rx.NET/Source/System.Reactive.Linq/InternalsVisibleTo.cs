﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;

#if SIGNED

#if SIGNENHANCED // Key 272 for .NET 4.5 and beyond
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Debugger, PublicKey=002400000c80000014010000060200000024000052534131000800000100010085aad0bef0688d1b994a0d78e1fd29fc24ac34ed3d3ac3fb9b3d0c48386ba834aa880035060a8848b2d8adf58e670ed20914be3681a891c9c8c01eef2ab22872547c39be00af0e6c72485d7cfd1a51df8947d36ceba9989106b58abe79e6a3e71a01ed6bdc867012883e0b1a4d35b1b5eeed6df21e401bb0c22f2246ccb69979dc9e61eef262832ed0f2064853725a75485fa8a3efb7e027319c86dec03dc3b1bca2b5081bab52a627b9917450dfad534799e1c7af58683bdfa135f1518ff1ea60e90d7b993a6c87fd3dd93408e35d1296f9a7f9a97c5db56c0f3cc25ad11e9777f94d138b3cea53b9a8331c2e6dcb8d2ea94e18bf1163ff112a22dbd92d429a")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Experimental, PublicKey=002400000c80000014010000060200000024000052534131000800000100010085aad0bef0688d1b994a0d78e1fd29fc24ac34ed3d3ac3fb9b3d0c48386ba834aa880035060a8848b2d8adf58e670ed20914be3681a891c9c8c01eef2ab22872547c39be00af0e6c72485d7cfd1a51df8947d36ceba9989106b58abe79e6a3e71a01ed6bdc867012883e0b1a4d35b1b5eeed6df21e401bb0c22f2246ccb69979dc9e61eef262832ed0f2064853725a75485fa8a3efb7e027319c86dec03dc3b1bca2b5081bab52a627b9917450dfad534799e1c7af58683bdfa135f1518ff1ea60e90d7b993a6c87fd3dd93408e35d1296f9a7f9a97c5db56c0f3cc25ad11e9777f94d138b3cea53b9a8331c2e6dcb8d2ea94e18bf1163ff112a22dbd92d429a")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.PlatformServices, PublicKey=002400000c80000014010000060200000024000052534131000800000100010085aad0bef0688d1b994a0d78e1fd29fc24ac34ed3d3ac3fb9b3d0c48386ba834aa880035060a8848b2d8adf58e670ed20914be3681a891c9c8c01eef2ab22872547c39be00af0e6c72485d7cfd1a51df8947d36ceba9989106b58abe79e6a3e71a01ed6bdc867012883e0b1a4d35b1b5eeed6df21e401bb0c22f2246ccb69979dc9e61eef262832ed0f2064853725a75485fa8a3efb7e027319c86dec03dc3b1bca2b5081bab52a627b9917450dfad534799e1c7af58683bdfa135f1518ff1ea60e90d7b993a6c87fd3dd93408e35d1296f9a7f9a97c5db56c0f3cc25ad11e9777f94d138b3cea53b9a8331c2e6dcb8d2ea94e18bf1163ff112a22dbd92d429a")]
#else            // Key 35 for older platforms
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Debugger, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Experimental, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.PlatformServices, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Tests.System.Reactive, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
#endif

#else

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Debugger")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Experimental")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.PlatformServices")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Tests.System.Reactive")]

#endif