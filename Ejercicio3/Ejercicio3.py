from pyswip import Prolog
prolog= Prolog()
#abuelosP abuelos de parte de mi padre
prolog.assertz("abuelosP(Fidel,Nieves)")
#abuelosA de parte de mi madre
prolog.assertz("abuelosA(Juan,Rita)")
#en esta parte colocaremos a los primos
prolog.assertz("primo(Ronald,Wara)")
list(prolog.query("abuelosP(Fidel,X)"))==[{"X":"Nieves"},{"Y":"Ronald"}]
list(prolog.query("primo(Ronald,X)"))==[{"X":"Wara"},{"Y":"Jose"}]
for elemento in prolog.query("abuelosP(X,Y)"): print(elemento["X"],"es el abuelo",elemento["Y"])
for elemento in prolog.query("primo(X,Y)"): print(elemento["X"],"es primo",elemento["Y"])
