import React from 'react';
import { Container } from 'semantic-ui-react';
import NavBar from './NavBar'
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';
import { observer } from 'mobx-react-lite';
import { Route } from 'react-router-dom';
import HomePage from '../../features/Home/HomePage';
import ActivityForm from '../../features/activities/form/ActivityForm';
import ActivityDetail from '../../features/activities/details/ActivityDetail';

function App() {
  return (
    <> 
      <NavBar  />
      <Container style={{marginTop:'7em'}}>
        <Route exact path ="/" component={HomePage} />
        <Route exact path ="/activities" component={ActivityDashboard} />
        <Route path ="/activities/:id" component={ActivityDetail} />
        <Route path ="/createActivity" component={ActivityForm} />
      </Container>
    </>
  );
}

export default observer(App);
