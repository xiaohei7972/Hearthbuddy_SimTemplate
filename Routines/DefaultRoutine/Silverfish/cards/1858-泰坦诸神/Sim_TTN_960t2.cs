using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：0
	//To the Void!
	//打入虚空！
	//[x]Send all other minionsinto the Twisting Nether.
	//将所有其他随从送入扭曲虚空。
	class Sim_TTN_960t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.ownMinions.Where(m => m.handcard.card.cardIDenum != CardDB.cardIDEnum.TTN_960).ToList().ForEach(m =>
            {
                p.RemoveMinionWithoutDeathrattle(m); // 送入扭曲虚空
            });
            p.enemyMinions.ForEach(m =>
            {
                p.RemoveMinionWithoutDeathrattle(m); // 送入扭曲虚空
            });
        }
    }
}
