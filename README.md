# Progra3D_Exercices_2021

## Exercice 1
	Création de cube suivant la forme d'un cercle. Le nombre de cube spawnable est configurable directement sur unity.

## Exercice 2: Mini Projet FPS
	Le but est de crée un FPS. Le projet est capable de faire apparaitre des projectiles pour toucher des cibles, au 
	tel cas les cibles compartant le même layer seront detruitent.
	Dans un 2eme temps j'ai crée une ligne de cube avec un layeer differents. Le cube changera de couleur quand on les touche.

## Exercice 3: UI
	Le Projet se lance avec la scene Main.
	Il y a 2 scenes:
		- Le Main est une page d'acceuil, avec les credit et le bouton start.
		- Dialogue est le "jeu" entre Sonic et Mario. Ils parlent chacun leur tour( les phrases choisis sont juste pour le contenu, pas d'inspi :) )
		Mon probleme est que les dialogues stocker dans des ScriptableObjects se "conrrompent " seul le 1,4,6 marches. J'ai deja essayé de les recrée , mais j'ai toujours 
		le même erreur...
		( Correction: mon ScriptableObjects a une erreur ( The associated script can not be leaded. Please fix any compile errors and assign a valid scripts), mais ça ne l'empeche pas
		de par fois lancer le dialogue. Je ne comprend pas... 
	L'UI suit le changement de format de l'écran, tant qu'il n'est pas trop petit.