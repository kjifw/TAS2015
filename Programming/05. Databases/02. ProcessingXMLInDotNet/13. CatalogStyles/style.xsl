<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <style>
          body {
            padding-left: 30px; 
          }
          .songs {
            padding-left: 20px;
          }
        </style>
      </head>
      <body>
        <h2>Albums Catalogue</h2>
        <xsl:for-each select="catalogue/album">
          <div>
            <div>
              Name: &#160;
              <xsl:value-of select="name"/>
            </div>
            <div>
              Artist: &#160;
              <xsl:value-of select="artist"/>
            </div>
            <div>
              Year: &#160;
              <xsl:value-of select="year"/>
            </div>
            <div>
              Producer: &#160;
              <xsl:value-of select="producer"/>
            </div>
            <div>
              Price: &#160;
              <xsl:value-of select="price"/>
            </div>
            <div>
              Songs: &#160;
              <xsl:for-each select="songs/song">
                <div class="songs">
                  <div>
                    Title: &#160;
                    <xsl:value-of select="title"/>
                  </div>
                  <div>
                    Duration: &#160;
                    <xsl:value-of select="duration"/>
                  </div>
                </div>
              </xsl:for-each>
            </div>
          </div>
          <br />
        </xsl:for-each>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>