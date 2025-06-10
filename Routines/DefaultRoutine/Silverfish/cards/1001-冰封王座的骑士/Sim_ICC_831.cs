using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_831: SimTemplate //* 鲜血掠夺者古尔丹 Bloodreaver Gul'dan
//<b>Battlecry:</b> Summon all friendly Demons that_died_this_game.
//<b>战吼：</b>召唤所有在本局对战中死亡的友方恶魔。 
    {
        

        CardDB cdb = CardDB.Instance;
        CardDB.Card kid = null;

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.ICC_831p, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;


            int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
            int kids = 7 - pos;
            if (kids > 0)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_301), pos, ownplay); 
                kids--;

                if (kids > 0)
                {
                    foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownGraveyard)
                    {
                        kid = cdb.getCardDataFromID(e.Key);
                        if ((TAG_RACE)kid.race == TAG_RACE.DEMON)
                        {
                            for (int i = 0; i < e.Value; i++)
                            {
                                p.callKid(kid, pos, ownplay);
                                kids--;
                                if (kids < 1) break;
                            }
                            if (kids < 1) break;
                        }
                    }
                }
            }
        }
    }
}