using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：0
	//Inferno!
	//地狱火！
	//Summon two 6/6 Infernals from the Twisting Nether.
	//从扭曲虚空中召唤两个6/6的地狱火。
	class Sim_TTN_960t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 2; i++)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_960t5), p.ownMinions.Count, true, false); // 从扭曲虚空中召唤两个6/6的地狱火
            }
        }
    }
}
