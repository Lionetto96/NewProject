// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//ES1
//Scrivere un programma che simula un gioco di lancio dei dadi.

//L'utente inserisce un numero tra 2 e 12.

//Il computer lancia 2 dadi, cioè sorteggia 2 numeri random tra 1 e 6.
//Se la somma dei due numeri random è pari al numero scelto dall'utente,
//l'utente vince.
//Se l'utente vince, stampare 'hai vinto', altrimenti 'hai perso'.
//Finita la partita l'utente deve poter rigiocare.
//Requisiti:
//verificare che l'utente inserisca un intero e che sia compreso tra 2
//e 12.
//se la verifica non va a buon fine, l'utente deve potere inserire
//nuovamente il numero.
//Suggerimento:
//Creare una classe con i metodi che servono da chiamare nella classe
//program:
//per esempio un metodo per l'inserimento dei numeri e la verifica,
//uno per il controllo della vittoria.

int num = NewProject.GameManager.getNumber();

string s=Console.ReadLine();
//ES2
//Stampare un messaggio di benvenuto al gioco Morra Cinese.
//Chiedere il NOME dell'utente quindi stampare un messaggio del tipo "Ok NOME, iniziamo a giocare".



//Il computer sceglie (in modo random) una tra le possibili opzioni tra carta, sasso o forbice.
//Avvisa l'utente che ha effettuato la sua scelta quindi invita l'utente a fare lo stesso cioè
//a scegliere una delle 3 opzioni tra quelle disponibili per poter giocare contro di lui.



//Dopo la scelta dell'utente sarà quindi "valutato" il vincitore in base al confronto tra le opzioni scelte.
//Stampare a video un messaggio all'utente che dica se ha vinto, ha perso oppure c'è stato un pareggio.



//Ricordiamo che:
//Sasso vince su Forbice
//Carta vince su Sasso
//Forbice vince su Carta



//Al termine del gioco si richiede all'utente se desidera giocare ancora contro il computer.
//In caso affermativo si ricomincia a giocare,
//altrimenti si esce dal gioco e deve essere mostrato un messaggio di arrivederci.