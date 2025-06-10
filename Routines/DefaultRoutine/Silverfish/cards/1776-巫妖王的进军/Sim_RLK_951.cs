using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：2
	//Coroner
	//验尸官
	//<b>Battlecry:</b> <b>Freeze</b>an enemy minion.<b>Manathirst (6):</b><b>Silence</b> it first.
	//<b>战吼：</b><b>冻结</b>一个敌方随从。<b>法力渴求（6）：</b>先将其<b>沉默</b>。
	class Sim_RLK_951 : SimTemplate
	{
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),				
            };
        }				
		
	}
}
