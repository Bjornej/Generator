namespace Parser
{
    /// <summary>
    ///     Preprocesses a block of text to replace or execute macros before parsing
    /// </summary>
    public interface IPreProcessor
    {
        /// <summary>
        ///     Preprocesses a string of text
        /// </summary>
        /// <param name="input">Input to preprocess</param>
        /// <returns>Output to parse</returns>
        string Preprocess(string input);
    }
}
