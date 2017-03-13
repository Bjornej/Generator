namespace Parser
{
    using Model;
    using System.IO;

    /// <summary>
    ///     base parser interface, takes a string returns the parsed type
    /// </summary>
    public interface IParser
    {
        /// <summary>
        ///     Parses a string constructing the type representation
        /// </summary>
        /// <param name="text">Text to parse</param>
        /// <returns>Parsed type</returns>
        TypeProperty Parse(string text);
    }
}
