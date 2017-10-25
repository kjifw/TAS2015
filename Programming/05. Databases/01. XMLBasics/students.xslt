<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:template match="/">
        <html>
            <head>
                <style>
                    body {
                        padding-left: 50px;
                    }

                    #studentsCollection > label {
                        font-weight: 600;
                    }

                    #exams {
                        padding-left: 30px;
                    }
                </style>
            </head>
            <body>
                <h2>Students</h2>
                <xsl:for-each select="students/student">
                    <div id="studentsCollection">
                        <label for="name">Name: </label>
                        <span id="name"><xsl:value-of select="name" /></span><br />   
                        <label for="sex">Sex: </label>
                        <span id="sex"><xsl:value-of select="sex" /></span><br />    
                        <label for="birthDate">Birth Date: </label>
                        <span id="birthDate"><xsl:value-of select="birthDate" /></span><br />   
                        <label for="phone">Phone: </label>
                        <span id="phone"><xsl:value-of select="phone" /></span><br />                   
                        <label for="email">Phone: </label>
                        <span id="email"><xsl:value-of select="email" /></span><br />                 
                        <label for="course">Course: </label>
                        <span id="course"><xsl:value-of select="course" /></span><br />                  
                        <label for="specialty">Specialty: </label>
                        <span id="specialty"><xsl:value-of select="specialty" /></span><br />
                        <label for="facultyNumber">Faculty Number: </label>
                        <span id="facultyNumber"><xsl:value-of select="facultyNumber" /></span><br />
                        <label for="exams">Exams: </label>                    
                        <div id="exams">
                            <xsl:for-each select="exams/exam">
                                <label for="examName">Exam Name: </label>
                                <span id="examName"><xsl:value-of select="name" /></span><br />
                                <label for="examTutor">Exam Tutor: </label>
                                <span id="examTutor"><xsl:value-of select="tutor" /></span><br />
                                <label for="examScore">Exam Score: </label>
                                <span id="examScore"><xsl:value-of select="score" /></span><br />
                            </xsl:for-each>
                        </div>
                        <br />
                    </div>
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>