﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using Microsoft.VisualStudio.Text.Adornments;
using Microsoft.VisualStudio.Text.Editor;

namespace dnSpy.Contracts.Text.Editor {
	/// <summary>
	/// Predefined <see cref="ISpaceReservationManager"/> names
	/// </summary>
	public static class PredefinedSpaceReservationManagerNames {
		/// <summary>
		/// Current line space reservation manager name
		/// </summary>
		public const string CurrentLine = "currentline";

		/// <summary>
		/// Completion space reservation manager name
		/// </summary>
		public const string Completion = "completion";

		/// <summary>
		/// Signature help space reservation manager name
		/// </summary>
		public const string SignatureHelp = "signaturehelp";

		/// <summary>
		/// Quick info space reservation manager name
		/// </summary>
		public const string QuickInfo = "quickinfo";

		/// <summary>
		/// Smart tag space reservation manager name
		/// </summary>
		public const string SmartTag = "smarttag";

		/// <summary>
		/// <see cref="IToolTipProvider"/>
		/// </summary>
		public const string ToolTip = "ToolTip";
	}
}