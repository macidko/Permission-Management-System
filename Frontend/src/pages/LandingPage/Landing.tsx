import "./Landing.css";
import Logo from "../../assets/pmsLogo3.png";
import { Button, Container, Row, Col, Image } from "react-bootstrap";
import { Link } from "react-router-dom";

const Landing = () => {
  return (
    <Container fluid className="landing-container">
      <Row className="justify-content-center align-items-center vh-100">
        <Col md={3} className="text-center">
          <Image src={Logo} alt="PermissionPro Logo" className="logo" />
        </Col>
        <Col md={5} className="text-center">
          <h1 className="display-1 mb-2">PermissionPro</h1>
          <p className="lead">
            Manage User Permissions efficiently and securely!
          </p>
          <div className="mt-5 text-center d-flex flex-column">
            <Link to="/register">
              <Button className="landing-btn mb-3 bg-success text-white">
                Get Started
              </Button>
            </Link>
            <Link to="/login">
              <Button className="landing-btn bg-success text-white">
                Access
              </Button>
            </Link>
          </div>
        </Col>
      </Row>
    </Container>
  );
};

export default Landing;
