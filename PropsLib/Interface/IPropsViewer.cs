namespace PropsLib.Interface
{
    public interface IPropsViewer
    {
        /// <summary>
        /// Sets the source of the image and immediatly starts parsing. 
        /// </summary>
        /// <param name="source"></param>
        bool SetSource(string source);

        /// <summary>
        /// Returns the ratio of the image. 
        /// </summary>
        /// <value></value>
        float Ratio { get; }

        /// <summary>
        /// Creates the actual 32bit (ARGB) image data as byte stream. Expects the size of the image to
        /// render it. The image will fit inside the image and is centered. Unneeded parts will be transparent. 
        /// <para>It's up to the Viewer to provide a matching canvas size.</para>
        /// </summary>
        /// <param name="sizeX"></param>
        /// <param name="sizeY"></param>
        /// <returns></returns>
        byte[] GetImage(int sizeX, int sizeY);
    }
}