using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_248t : SimTemplate //* 魔钢处决者 Felsteel Executioner
	{
        //<b>Corrupted</b>
        //<b>已腐蚀</b>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_248t), true);
        }

    }
}
