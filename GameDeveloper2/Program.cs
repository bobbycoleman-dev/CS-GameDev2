// 1. Create Melee Fighter and Attacks
Melee ChuckNorris = new("Chuck Norris");
Attack Punch = new("Punch", 20);
Attack Kick = new("Kick", 15);
Attack Tackle = new("Tackle", 25);
ChuckNorris.AddAttack(Punch);
ChuckNorris.AddAttack(Kick);
ChuckNorris.AddAttack(Tackle);

// 1. Create Ranged Fighter and Attacks
Ranged Legolas = new("Legolas");
Attack Arrow = new("Shoot Arrow", 20);
Attack Knife = new("Throw Knife", 15);
Legolas.AddAttack(Arrow);
Legolas.AddAttack(Knife);

// 1. Create Magic Caster and Attacks
Magic ManInBlack = new("Man in Black");
Attack Fireball = new("Fireball", 25);
Attack Lightning = new("Lightning", 20);
Attack Staff = new("Staff Strike", 10);
ManInBlack.AddAttack(Fireball);
ManInBlack.AddAttack(Lightning);
ManInBlack.AddAttack(Staff);

// 2. Perform Kick from Melee on Ranged
ChuckNorris.PerformAttack(Legolas, Kick);

// 3. Perform Rage from Melee on Magic
ChuckNorris.Rage(ManInBlack);

// 4. Perform Arrow from Ranged on Melee
Legolas.PerformAttack(ChuckNorris, Arrow);

// 5. Have Ranged perform Dash Method
Legolas.Dash();

// 6. Perform Arrow from Ranged on Melee
Legolas.PerformAttack(ChuckNorris, Arrow);

// 7. Perform Fireball from Magic on Melee
ManInBlack.PerformAttack(ChuckNorris, Fireball);

// 8. Perform Heal from Magic on Ranged (Ranged current health is 85, should change to Ranged max of 100)
ManInBlack.Heal(Legolas);

// 9. Perform Heal from Magic on themselves
ManInBlack.Heal(ManInBlack);