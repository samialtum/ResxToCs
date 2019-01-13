﻿using System.IO;

namespace ResxToCs.Core.Helpers
{
	/// <summary>
	/// File helpers
	/// </summary>
	public static class FileHelpers
	{
		/// <summary>
		/// Checks if the content of a file on disk differs from the new content
		/// </summary>
		/// <param name="filePath">Path to file</param>
		/// <param name="newContent">New content</param>
		/// <returns>Result of check (true - is differ; false - is not differ)</returns>
		public static bool HasFileContentChanged(string filePath, string newContent)
		{
			if (!File.Exists(filePath))
			{
				return true;
			}

			string oldContent = File.ReadAllText(filePath);
			bool result = oldContent != newContent;

			return result;
		}
	}
}