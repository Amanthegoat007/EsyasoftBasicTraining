import React from 'react'
import { useContext } from 'react'
import {Context} from '../App'
const UseContextComponent = () => {
    const {theme}=useContext(Context);
  return (
    <div>
      Use Context Component {theme}
    </div>
  )
}

export default UseContextComponent
