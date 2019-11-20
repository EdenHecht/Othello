using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayers
{
    public class Player
    {
        public LinkedList<MoveOption>       m_ValidMoves = new LinkedList<MoveOption>();
        private char                        m_CoinColor;
        private eUserType                   m_UserType;
        private bool                        m_IsMyTurn = false;
        private int                         m_NumberOfWins = 0;

        public enum eUserType
        {
            Human,
            Computer
        }

        public eUserType UserType
        {
            get { return m_UserType; }
            set { m_UserType = value; }
        }

        public char CoinColor
        {
            get { return m_CoinColor; }
            set { m_CoinColor = value; }
        }

        public int NumberOfWins
        {
            get { return m_NumberOfWins; }
            set { m_NumberOfWins = value; }
        }

        public bool IsMyTurn
        {
            get { return m_IsMyTurn; }
            set { m_IsMyTurn = value; }
        }
    }
}
