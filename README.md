Credit Suisse – IT DEV RISK





Question 2:

 A new category was created called PEP (politically exposed person). Also, a new bool property
IsPoliticallyExposed was created in the ITrade interface. A trade shall be categorized as PEP if
IsPoliticallyExposed is true. Describe in at most 1 paragraph what you must do in your design to account for this
new category.


Response:

Para incorporar a nova categoria PEP ao projeto, vou  ter que fazer  primeiro  a classe Trade para que  implemente a interface ITrade, 
incluindo a propriedade IsPoliticallyExposed. 
Depois, na classe Program, ao criar instâncias de Trade,só passar um valor booleano indicando se o cliente associado à negociação é politicamente exposto.
Por fim, vou adicionar a classe PEPCategory como uma das categorias no TradeClassifier,
para que com ela eu possa avaliar se uma negociação é politicamente exposta com base no valor de IsPoliticallyExposed na instância de Trade fornecida.
