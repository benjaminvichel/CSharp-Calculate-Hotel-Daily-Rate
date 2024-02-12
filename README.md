# Introduction
<h3>
Hello! Thanks for reading my project!
</h3>

<p>The idea of this project is to calculate the value of the daily rate for a specific schadule's range. I use Mysql to store all the daily expenses prices.</p>
<p>The program also have CRUD so you do not have to make any changes using MySql interface.</p>
<p>This is my very first program, that I created in order to help my parents' hotel.</p>
<p>If you find any bugs or have sugestions, please give me a feedback in my e-mail adress: benni.vichel@hotmail.com.
</p>
<p>Thanks again!</p>

# How it Works

<p>
The end customer will choose a start date and an end date in the program.</p>
<p>The program will fetch the values ​​on the specified date and return them to the customer's screen.</p>

![](gifs/1.gif)

![](gifs/2.gif)

<p></p>

## Sections

 ### Section 1 (valores)

![section 1](images/section%201.png)

<p>In this section, we have:</p>
<p>🛌 Casal (Double room)</p>
<p>🛌 Casal - Luxo (Luxury double room)</p>
<p>🛌 Solteiro (Single value)</p>
<p>🛌Triplo (Triple room)</p>
<p>🛌Quadruplo (Quadruple room)</p>
<p>🛌Quintuplo (Quintuple room)</p>

<p>We also have 2 columns: Diária (daily) and Total (total)</p>
<p>Diária (daily) is the daily rate. calculated by dividing the total daily rate by the number of days.</p>
<p>Total (total) is the total price.</p>
<p>The "single value" is not the value for a room with single bed, but it's the value the program uses to calculate the cost for the triple,quadruple and quintuple rooms.</p>

<p style="font-size: 25px;">Example:</p>

![example](images/example.png)

<p>In the image the double room value is R$ 420,00. Adding the "single value(solteiro)" with the "double room value(casal)" we get the "triple room value(triplo)".</p>
<p>double room (420,00)+ single value(100,00) = triple room (520,00).</p>
<p>We do exactly the same thing to quadruple and quintuple rooms.</p>

### Section 2 (Quarto customizado)
<p>In section 1 we only have room prices for guests over 10 years old. To find out the value of, for example, a triple room with a couple and a child, we use section 2.</p>

![section 2](images/section%202.png)

<p>Add the amount in each field and click the calculate daily rate button(calcular diárias).</p>
<p>The base value in section 2 will always be the value of the double room.</p>

![](gifs/2.gif)

### Section 3 (Quarto customizado)
<p>In section 3 the calculated number of daily rates will be shown</p>

![section 3](images/section%203.png)

#CRUD
<p>Edit your values using CRUD</p>
<p>Password: nathanota10</p>

![](gifs/3.gif)

![](gifs/4.gif)

# To Know
<p>Microsoft Visual Stiudio Community 2019</p>
<p>version 16.11.33</p>
<p>Microsoft .NET Framework</p>
<p>Version 4.8.09037</p>
<p>WampServer-3.3.2</p>

