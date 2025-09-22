import React, { useReducer } from 'react'

const reducer=(state,action)=>{
    switch(action.type){
        case 'inc':return {...state,count:state.count+1}
        case 'dec':return {...state,count:state.count-1}
        default: return state;
    }
}
const UseReducerComponent = () => {

    const [state,dispatch]=useReducer(reducer,{count:0})
  return (
    <div>
        <p>{state.count}</p>
      <button onClick={()=>dispatch({type:'inc'})}>Increase</button>
      <button onClick={()=>dispatch({type:'dec'})}>Decrease</button>
    </div>
  )
}

export default UseReducerComponent
